//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 템플릿에서 생성되었습니다.
//
//     이 파일을 수동으로 변경하면 응용 프로그램에서 예기치 않은 동작이 발생할 수 있습니다.
//     이 파일을 수동으로 변경하면 코드가 다시 생성될 때 변경 내용을 덮어씁니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HompPage.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Articles
    {
        public int ArticleIDX { get; set; }
        public Nullable<int> BoardIDX { get; set; }
        public string ArticleType { get; set; }
        public string Title { get; set; }
        public string Contents { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string IPAddress { get; set; }
        public Nullable<int> ViewCnt { get; set; }
        public Nullable<System.DateTime> RegistDate { get; set; }
        public string RegistUserName { get; set; }
        public Nullable<System.DateTime> ModifyDate { get; set; }
        public string ModifyUserName { get; set; }
    }
}
