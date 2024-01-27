using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAccountingGetRadiusServerListRequest. The Radius Server table
    /// column headings are: "Net Address", "Port", "Description"
    /// <see cref="SystemAccountingGetRadiusServerListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:1974""}]")]
    public class SystemAccountingGetRadiusServerListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _radiusServerTable;

        [XmlElement(ElementName = "radiusServerTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:1974")]
        public BroadWorksConnector.Ocip.Models.C.OCITable RadiusServerTable
        {
            get => _radiusServerTable;
            set
            {
                RadiusServerTableSpecified = true;
                _radiusServerTable = value;
            }
        }

        [XmlIgnore]
        protected bool RadiusServerTableSpecified { get; set; }

    }
}
