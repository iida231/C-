using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace TodoApp.Models
{
    /// <summary>
    /// 認証認可のクラス
    /// </summary>
    public class CustomRoleProvider : RoleProvider
    {
        public override string ApplicationName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void AddUsersToRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override void CreateRole(string roleName)
        {
            throw new NotImplementedException();
        }

        public override bool DeleteRole(string roleName, bool throwOnPopulatedRole)
        {
            throw new NotImplementedException();
        }

        public override string[] FindUsersInRole(string roleName, string usernameToMatch)
        {
            throw new NotImplementedException();
        }

        public override string[] GetAllRoles()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// 指定されたユーザーを配列で返す
        /// </summary>
        /// <param name="username">ユーザーネーム</param>
        /// <returns></returns>
        public override string[] GetRolesForUser(string username)
        {
            //if ("administrator".Equals(username))
            //{
            //    return new string[] { "Administrators" };
            //}
            //return new string[] { "Users" };

            using (var db = new TodoesContext())
            {
                var user = db.Users
                    .Where(u => u.UserName == username)
                    .FirstOrDefault();

                if (user != null)
                {
                    return user.Roles.Select(role => role.RoleName).ToArray();
                }
            }
            return new string[] { };
        }

        public override string[] GetUsersInRole(string roleName)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// ユーザーが役割に所属しているか
        /// </summary>
        /// <param name="username"></param>
        /// <param name="roleName"></param>
        /// <returns></returns>
        public override bool IsUserInRole(string username, string roleName)
        {
            //if ("administor".Equals(username) && "Administrators".Equals(roleName))
            //{
            //    return true;
            //}

            //if ("user".Equals(username) && "Users".Equals(roleName))
            //{
            //    return true;
            //}

            string[] roles = this.GetRolesForUser(username);
            return roles.Contains(username);
            return false;
        }

        public override void RemoveUsersFromRoles(string[] usernames, string[] roleNames)
        {
            throw new NotImplementedException();
        }

        public override bool RoleExists(string roleName)
        {
            throw new NotImplementedException();
        }
    }
}