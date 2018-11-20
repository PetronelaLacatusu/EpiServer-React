using EPiServer.Framework;
using EPiServer.Framework.Initialization;
using EPiServer.Logging.Compatibility;
using System;
using System.Collections.Generic;
using System.Configuration.Provider;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Episerver_React.Business.Initialization
{
    [InitializableModule]
    public class CreateAdminUserAndRoles : IInitializableModule
    {
        private static readonly ILog Log = LogManager.GetLogger(typeof(CreateAdminUserAndRoles));

        public void Initialize(InitializationEngine context)
        {
#if DEBUG
            var mu = Membership.GetUser("admin");

            if (mu != null) return;

            try
            {
                Membership.CreateUser("admin", "6hEthU", "admin@site.com");

                try
                {
                    this.EnsureRoleExists("WebEditors");
                    this.EnsureRoleExists("WebAdmins");

                    Roles.AddUserToRoles("admin", new[] { "WebAdmins", "WebEditors" });
                }
                catch (ProviderException pe)
                {
                    Log.Error(pe);
                }
            }
            catch (MembershipCreateUserException mcue)
            {
                Log.Error(mcue);
            }
#endif
        }

        public void Uninitialize(InitializationEngine context)
        {
        }

        private void EnsureRoleExists(string roleName)
        {
            if (Roles.RoleExists(roleName)) return;

            try
            {
                Roles.CreateRole(roleName);
            }
            catch (ProviderException pe)
            {
                Log.Error(pe);
            }
        }
    }
}