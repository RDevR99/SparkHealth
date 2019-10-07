﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lapbase.LapbaseModels;
using Lapbase.Models;
using Lapbase.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lapbase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentController : Controller
    {
        private readonly AppointmentService appointmentService;

        public AppointmentController(AppointmentService appointmentService)
        {
            this.appointmentService = appointmentService;
        }

        // GET: api/Appointment/5/2
        [HttpGet("{id}/{organizationCode}")]
        public async Task<ActionResult<List<Appointment>>> GetAppointmentsById(int id, int organizationCode)
        {
            return await appointmentService.GetAppointmentById(id, organizationCode);
        }

        // GET: api/Next/Appointment/5/2
        [HttpGet("/Next/{id}/{organizationCode}")]
        public async Task<ActionResult<Appointment>> GetNextAppointment(int id, int organizationCode)
        {
            return await appointmentService.GetNextAppointment(id, organizationCode);
        }

    }
}
