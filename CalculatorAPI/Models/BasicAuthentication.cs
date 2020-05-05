using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;
using System.Web.Http.Description;
using System.Net.Http;
using System.Net;
using System.Text;
using System.Threading;
using System.Security.Principal;

namespace CalculatorAPI.Models
{
    public class BasicAuthentication:AuthorizationFilterAttribute
    {      
        public override void OnAuthorization(HttpActionContext actionContext)
        {
            if (actionContext.Request.Headers.Authorization==null)
            {
                actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
            }
            else
            {
                string credentials = actionContext.Request.Headers.Authorization.Parameter;
                string Dcredentials= Encoding.UTF8.GetString(Convert.FromBase64String(credentials));
                string[] CredentialsArr = Dcredentials.Split(':');
                string username = CredentialsArr[0];
                string password = CredentialsArr[1];
                if (Authentication.Verify(username, password))
                {
                    Thread.CurrentPrincipal = new GenericPrincipal(new GenericIdentity(username), null);
                }
                else
                {
                    actionContext.Response = actionContext.Request.CreateResponse(HttpStatusCode.Unauthorized);
                }
            }
        }

       
    }
}