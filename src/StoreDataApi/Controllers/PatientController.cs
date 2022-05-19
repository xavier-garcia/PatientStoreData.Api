using Microsoft.AspNetCore.Mvc;
using StorePatientData.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using StoreData.DataAccess.Repositories;

namespace StoreDataApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly ILogger<PatientController> _logger;
        private readonly IPatientRepository _patientRepository;

        public PatientController(ILogger<PatientController> logger, IPatientRepository patientRepository)
        {
            _logger = logger;
            _patientRepository = patientRepository;
        }

        [HttpGet]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public ActionResult<Patient> Get(int number)
        {
            return _patientRepository.Get(number);
        }

        [HttpPost]
        [ProducesResponseType((int)HttpStatusCode.OK)]
        public ActionResult<Guid> Add(AddPatientRequest addPatientRequest)
        {
            var patientId = _patientRepository.Add(addPatientRequest);

            return Ok(patientId);
        }
    }
}
