using log4net;
using TaskManager.Common;
using TaskManager.Common.Logging;
using TaskManager.Data.Entities;
using TaskManager.Web.Common;
using NHibernate;
using System.Security.Claims;
using System.Security.Principal;
using System.Threading;
using System.Web;

namespace TaskManager.Web.Api.Security
{
    public class BasicSecurityService : IBasicSecurityService
    {
        private readonly ILog _log;

        public BasicSecurityService(ILogManager logManager)
        {
            _log = logManager.GetLog(typeof(BasicSecurityService));
        }

        public virtual ISession Session
        {
            get { return WebContainerManager.Get<ISession>(); }
        }

        public bool SetPrincipal(string username, string password)
        {
            //var user = GetUser(username);

            //IPrincipal principal = null;
            //if (user == null || (principal = GetPrincipal(user)) == null)
            //{
            //    _log.DebugFormat("System could not validate user {0}", username);
            //    return false;
            //}

            //Thread.CurrentPrincipal = principal;
            //if (HttpContext.Current != null)
            //{
            //    HttpContext.Current.User = principal;
            //}

            return true;
        }

        //public virtual IPrincipal GetPrincipal(User user)
        //{
        //    var identity = new GenericIdentity(user.Username, Constants.SchemeTypes.Basic);

        //    identity.AddClaim(new Claim(ClaimTypes.GivenName, user.Firstname));
        //    identity.AddClaim(new Claim(ClaimTypes.Surname, user.Lastname));

        //    var username = user.Username.ToLowerInvariant();
        //    switch (username)
        //    {
        //        case "dbrown":
        //            identity.AddClaim(new Claim(ClaimTypes.Role, Constants.RoleNames.Admin));
        //            identity.AddClaim(new Claim(ClaimTypes.Role, Constants.RoleNames.SuperUser));
        //            identity.AddClaim(new Claim(ClaimTypes.Role, Constants.RoleNames.User));
        //            break;
        //        case "achristie":
        //            identity.AddClaim(new Claim(ClaimTypes.Role, Constants.RoleNames.SuperUser));
        //            identity.AddClaim(new Claim(ClaimTypes.Role, Constants.RoleNames.User));
        //            break;
        //        case "gmasterton":
        //            identity.AddClaim(new Claim(ClaimTypes.Role, Constants.RoleNames.User));
        //            break;
        //        default:
        //            return null;
        //    }

        //    return new ClaimsPrincipal(identity);
        //}

        //public virtual User GetUser(string username)
        //{
        //    username = username.ToLowerInvariant();
        //    return Session.QueryOver<User>().Where(x => x.Username == username).SingleOrDefault();
        //}
    }
}