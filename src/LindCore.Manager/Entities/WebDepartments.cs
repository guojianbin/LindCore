//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace LindCore.Manager.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class WebDepartments : LindCore.Domain.Entities.EntityInt
    {
        public WebDepartments()
        {
            this.WebManageRoles = new List<WebManageRoles>();
            this.WebManageUsers = new List<WebManageUsers>();
            this.Sons = new List<WebDepartments>();
        }
        [DisplayName("部门名称"), Required]
        public string Name { get; set; }
        [DisplayName("描述")]
        public string About { get; set; }
        [DisplayName("排序"), Required]
        public int SortNumber { get; set; }
        [DisplayName("操作者")]
        public string Operator { get; set; }
        [DisplayName("級別"), Required]
        public int Level { get; set; }

        public virtual IList<WebDepartments> Sons { get; set; }
        public virtual WebDepartments Father { get; set; }
        public virtual IList<WebManageRoles> WebManageRoles { get; set; }
        public virtual IList<WebManageUsers> WebManageUsers { get; set; }


    }
}
