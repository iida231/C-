using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TodoApp.Models
{
    /// <summary>
    /// TodoクラスとDbを接続するクラス
    /// </summary>
    public class TodoesContext:DbContext
    {
        /// <summary>
        /// Todoと接続する
        /// </summary>
        public DbSet<Todo> Todoes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}