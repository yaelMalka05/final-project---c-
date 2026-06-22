
using entities;
using Microsoft.AspNetCore.Authentication.JwtBearer;

//using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;


//using Microsoft.IdentityModel.Tokens;
using repository;
using service;
using System.Text;
using System.Threading.Channels;

namespace finalProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            builder.Services.AddEndpointsApiExplorer();

            builder.Services.AddSwaggerGen();
            builder.Services.AddSwaggerGen(options =>
                {
                    options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                    {
                        Scheme = "Bearer",
                        BearerFormat = "JWT",
                        In = ParameterLocation.Header,
                        Name = "Authorization",
                        Description = "Bearer Authentication with JWT Token",
                        Type = SecuritySchemeType.Http
                    });
                });





            builder.Services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidateIssuerSigningKey = true,
            ValidIssuer = builder.Configuration["JWT:Issuer"],
            ValidAudience = builder.Configuration["JWT:Audience"],
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["JWT:Key"]))
        };
    });






            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddDbContext<DataProject>();
                    builder.Services.AddSingleton<JwtService>();

                    builder.Services.AddScoped<IVolunteerRepository, VolunteerRepository>();
                    builder.Services.AddScoped<VolunteerService, VolunteerService>();

                    builder.Services.AddScoped<ITaskRepository, TaskRepository>();
                    builder.Services.AddScoped<TaskService, TaskService>();

                    builder.Services.AddScoped<IAssignmentRepository, AssignmentRepository>();
                    builder.Services.AddScoped<AssignmentService, AssignmentService>();

            builder.Services.AddAutoMapper(cfg =>
            {
                cfg.AddProfile<MappingProfile>();
            }, typeof(MappingProfile).Assembly);


            var app = builder.Build();

                    // Configure the HTTP request pipeline.
                    if (app.Environment.IsDevelopment())
                    {
                        app.UseSwagger();
                        app.UseSwaggerUI();
                    }

            app.UseHttpsRedirection();
            app.UseAuthentication();
            app.UseAuthorization();

            app.Use((context, next) =>
            {
                var method = context.Request.Method;
                Console.WriteLine($"{method} request in {DateTime.Now}");
                return next(context);
            });

            app.Use((context, next) =>
            {
                var hour = DateTime.Now.Hour;
                var method = context.Request.Method;
                if (hour < 8 && (method == "PUT" || method == "DELETE"))
                    return context.Response.WriteAsync("this is not allow un this time");
                return next(context);
            });

            app.MapControllers();

                    app.Run();
                }
        }
    }


