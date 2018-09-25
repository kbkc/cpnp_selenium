using System;
using System.Text;
using System.Collections.Generic;
using FluentNHibernate.Mapping;


namespace cpnp_selenium {

    public class CpnpQueriesMap : ClassMap<CpnpQueries>
    {
        public CpnpQueriesMap()
        {
            Table("cpnp_queries");
            LazyLoad();
            Id(x => x.id).GeneratedBy.Identity().Column("id");
            Map(x => x.squery).Column("squery");
            Map(x => x.descr).Column("descr");
        }
    }
}

