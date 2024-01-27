using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemRoutePointExternalSystemGetListRequest.
    /// 
    /// Contains a table with column headings:
    /// "External System", "Description".
    /// <see cref="SystemRoutePointExternalSystemGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:15355""}]")]
    public class SystemRoutePointExternalSystemGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _externalSystemTable;

        [XmlElement(ElementName = "externalSystemTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:15355")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ExternalSystemTable
        {
            get => _externalSystemTable;
            set
            {
                ExternalSystemTableSpecified = true;
                _externalSystemTable = value;
            }
        }

        [XmlIgnore]
        protected bool ExternalSystemTableSpecified { get; set; }

    }
}
