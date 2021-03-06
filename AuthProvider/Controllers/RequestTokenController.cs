﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AuthProvider.Models;
using AuthProvider.Handlers;

namespace AuthProvider.Controllers
{
    [Route("api/[controller]")]
    public class RequestTokenController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get()
        {
            NewTokenRequestHandler handler = new NewTokenRequestHandler(new Models.Requests.NewToken {
                Username = "kablaa",
                Password = "password",
            });
            if (handler.VerifyUser())
            {
                return handler.GenerateJWT();
            }
            else
                return "Invalid Credentials";
            
        }


    }
}