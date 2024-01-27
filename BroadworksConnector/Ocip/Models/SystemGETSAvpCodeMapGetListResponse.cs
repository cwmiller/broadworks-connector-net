using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemGETSAvpCodeMapGetListRequest.
    /// The table columns are: "AVP Code" and "Vendor ID".
    /// <see cref="SystemGETSAvpCodeMapGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:10943""}]")]
    public class SystemGETSAvpCodeMapGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _avpCodeTable;

        [XmlElement(ElementName = "avpCodeTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:10943")]
        public BroadWorksConnector.Ocip.Models.C.OCITable AvpCodeTable
        {
            get => _avpCodeTable;
            set
            {
                AvpCodeTableSpecified = true;
                _avpCodeTable = value;
            }
        }

        [XmlIgnore]
        protected bool AvpCodeTableSpecified { get; set; }

    }
}
