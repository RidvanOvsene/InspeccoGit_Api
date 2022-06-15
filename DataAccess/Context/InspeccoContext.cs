using Core;
using Entities;
using Entities.Dtos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class InspeccoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Data Source=DESKTOP-639F8SA\SQLEXPRESS;Initial Catalog=InspeccoDb;Integrated Security=True");
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<OperationClaim> OperationClaims { get; set; }
        public DbSet<UserOperationClaim> UserOperationClaims { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Rol> Roles { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<RolPermission> RolPermission { get; set; }
        public DbSet<Menu> Menu { get; set; }
        public DbSet<UserMenu> UserMenu { get; set; }
        public DbSet<UserMenuDto> UserMenuDtoQuery { get; set; }
        public DbSet<RolPermissionDto> RolPermissionDtoQuery { get; set; }
        public DbSet<UsersDto> UserDtoQuery { get; set; }
        public DbSet<PersonDto> PersonDtoQuery { get; set; }
    }
}
