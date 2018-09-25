using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using cpnp_selenium; 

namespace cpnp_selenium {
    
    
    public class CpnpMap : ClassMap<Cpnp> {
        
        public CpnpMap() {
			Table("cpnp");
			LazyLoad();
			Id(x => x.id).GeneratedBy.Identity().Column("id");
			Map(x => x.cpnpVal).Column("cpnp");
			Map(x => x.sname).Column("sname");
			Map(x => x.url).Column("url");
        }
    }
}
