using DocumentValidations.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DocumentValidations.Controllers
{
    [RoutePrefix("api/document")]
    public class DocumentController : ApiController
    {

        [Route("cpf")]
        [HttpGet]
        public HttpResponseMessage RetornaCpf()
        {
            string cpf = Cpf.GerarCpf();

            return Request.CreateResponse(HttpStatusCode.OK, cpf);
        }

        [Route("cpf")]
        [HttpPost]
        public HttpResponseMessage VerificaCpf(string cpf)
        {
            if (Cpf.IsCpf(cpf))
                return Request.CreateResponse(HttpStatusCode.OK, "Cpf é válido");
            else
                return Request.CreateResponse(HttpStatusCode.OK, "Cpf não é válido");
        }

        [Route("cnpj")]
        [HttpGet]
        public HttpResponseMessage RetornaCnpj()
        {
            string cnpj = Cnpj.geraCNPJ();

            return Request.CreateResponse(HttpStatusCode.OK, cnpj);
        }

        [Route("cnpj")]
        [HttpPost]
        public HttpResponseMessage VerificaCnpj(string cnpj)
        {
            if(Cnpj.IsCnpj(cnpj))
                return Request.CreateResponse(HttpStatusCode.OK, "Cnpj é válido");
            else
                return Request.CreateResponse(HttpStatusCode.OK, "Cnpj não é válido");
        }
    }
}
