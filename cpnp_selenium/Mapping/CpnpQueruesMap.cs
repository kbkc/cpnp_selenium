using System; 
using System.Collections.Generic; 
using System.Text; 
using FluentNHibernate.Mapping;
using cpnp_selenium; 

namespace cpnp_selenium {
    
    
    public class CpnpQueruesMap : ClassMap<CpnpQuerues> {
        
        public CpnpQueruesMap() {
			Table("cpnp_querues");
			LazyLoad();
			Id(x => x.id).GeneratedBy.Identity().Column("id");
			Map(x => x.squery).Column("squery");
			Map(x => x.descr).Column("descr");
        }
    }
}
