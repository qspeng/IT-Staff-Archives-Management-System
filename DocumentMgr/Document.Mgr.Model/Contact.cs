//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Document.Mgr.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Contact
    {
        public int Id { get; set; }
        public string PersonalEmail { get; set; }
        public string PhoneNumber { get; set; }
        public string BlogUrl { get; set; }
        public string WX { get; set; }
    
        public virtual UserInfo UserInfo { get; set; }
    }
}
