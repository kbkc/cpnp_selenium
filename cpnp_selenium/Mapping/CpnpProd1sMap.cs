using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using cpnp_selenium; 

namespace cpnp_selenium {
    
    
    public class CpnpProd1sMap : ClassMap<CpnpProd1s> {
        
        public CpnpProd1sMap() {
			Table("cpnp_prod1s");
			LazyLoad();
			Id(x => x.id).GeneratedBy.Identity().Column("id");
			Map(x => x.art).Column("art");
			Map(x => x.sname_1s).Column("sname_1s");
			Map(x => x.cpnp_exist).Column("cpnp_exist");
			Map(x => x.cpnp_to_add).Column("cpnp_to_add");
            Map(x => x.ftmp).Column("ftmp");
        }
    }
}
