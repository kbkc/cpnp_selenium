using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using cpnp_selenium; 

namespace cpnp_selenium {
    
    public class CpnpArtMap : ClassMap<CpnpArt> {
        
        public CpnpArtMap() {
			Table("cpnp_art");
			LazyLoad();
			Id(x => x.id).GeneratedBy.Identity().Column("id");
			Map(x => x.cpnp).Column("cpnp");
			Map(x => x.art).Column("art");
			Map(x => x.sname).Column("sname");
        }
    }
}
