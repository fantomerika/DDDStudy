using System;
using Xunit;
using Undefine.Domain.Model;

namespace Undefine.UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {  
            var a = new Sys_User();
            
            Assert.IsType(typeof(DBNull), a.Id);
        }
    }
}
