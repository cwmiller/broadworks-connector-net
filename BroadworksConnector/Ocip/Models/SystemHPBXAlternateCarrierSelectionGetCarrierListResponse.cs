using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to the SystemHPBXAlternateCarrierSelectionGetCarrierListRequest.
    /// Contains a table with column headings:
    /// "Carrier Name", "Carrier Prefix", "Carrier Domain", "Carrier Type"
    /// The possible values for Carrier Type are "Local And Distant" and "Distant".
    /// <see cref="SystemHPBXAlternateCarrierSelectionGetCarrierListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:11449""}]")]
    public class SystemHPBXAlternateCarrierSelectionGetCarrierListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _hPBXAlternateCarriersTable;

        [XmlElement(ElementName = "HPBXAlternateCarriersTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:11449")]
        public BroadWorksConnector.Ocip.Models.C.OCITable HPBXAlternateCarriersTable
        {
            get => _hPBXAlternateCarriersTable;
            set
            {
                HPBXAlternateCarriersTableSpecified = true;
                _hPBXAlternateCarriersTable = value;
            }
        }

        [XmlIgnore]
        protected bool HPBXAlternateCarriersTableSpecified { get; set; }

    }
}
