//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Client_serv
{
    using System;
    using System.Collections.Generic;
    
    public partial class Buildings
    {
        public Buildings()
        {
            this.Rooms = new HashSet<Rooms>();
        }
    
        public int BuildingID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    
        public virtual ICollection<Rooms> Rooms { get; set; }
    }
}
