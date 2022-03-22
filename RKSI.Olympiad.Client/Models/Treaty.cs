//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RKSI.Olympiad.Client.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Treaty
    {
        public int TreatyNumber { get; set; }
        public System.DateTime TreatyDate { get; set; }
        public int ClientId { get; set; }
        public int HotelRoomId { get; set; }
        public System.DateTime DateEntrance { get; set; }
        public System.DateTime DateEscape { get; set; }
        public int SumOfPay { get; set; }
        public string PaymentMethod { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual HotelRoom HotelRoom { get; set; }

        [NotMapped]
        public string StringEscapeDate => DateEscape.Date.ToString("dd MMMM");
        [NotMapped]
        public string StringEntranceDate => DateEntrance.Date.ToString("dd MMMM");
    }
}
