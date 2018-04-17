using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Reflection;

namespace Undefine.Repository.Models
{
    public class UndefineDBContext : DbContext, IDisposable
    {
        //public UndefineDBContext() : base(ConfigPara.EFDBConnection)
        //{ }
        public UndefineDBContext(DbContextOptions<UndefineDBContext> options) : base(options)
        { }


        /// <summary>
        /// 重写配置类
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                .Where(q => q.GetInterface(typeof(IEntityTypeConfiguration<>).FullName) != null);

            foreach (var type in typesToRegister)
            {

                dynamic configurationInstance = Activator.CreateInstance(type);
                modelBuilder.ApplyConfiguration(configurationInstance);
            }
        }
    }
}
