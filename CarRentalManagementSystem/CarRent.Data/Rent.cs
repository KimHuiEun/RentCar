//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 템플릿에서 생성되었습니다.
//
//     이 파일을 수동으로 변경하면 응용 프로그램에서 예기치 않은 동작이 발생할 수 있습니다.
//     이 파일을 수동으로 변경하면 코드가 다시 생성될 때 변경 내용을 덮어씁니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarRent.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Rent
    {
        public int RentId { get; set; }
        public int UserId { get; set; }
        public int CarId { get; set; }
        public string Location { get; set; }
        public System.DateTime RentDate { get; set; }
        public Nullable<System.DateTime> ReturnDate { get; set; }
        public float InsuranceCoverage { get; set; }
        public int Price { get; set; }
    
        public virtual Car Car { get; set; }
        public virtual User User { get; set; }
    }
}