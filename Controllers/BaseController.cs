﻿namespace SvcStudentHorizons.Controllers;

using Microsoft.AspNetCore.Mvc;
using SvcStudentHorizons.Entities;

[Controller]
public abstract class BaseController : ControllerBase
{
    // returns the current authenticated account (null if not logged in)
    public Account Account => (Account)HttpContext.Items["Account"];
}