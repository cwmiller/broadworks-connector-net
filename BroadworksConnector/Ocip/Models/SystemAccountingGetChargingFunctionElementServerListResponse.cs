using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemAccountingGetChargingFunctionElementServerListRequest. The accounting charging function element Server table column
    /// headings are: "Address", "Extended Net Address", "Type", "Description".
    /// <see cref="SystemAccountingGetChargingFunctionElementServerListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:1943""}]")]
    public class SystemAccountingGetChargingFunctionElementServerListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _chargingFunctionElementServerTable;

        [XmlElement(ElementName = "chargingFunctionElementServerTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:1943")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ChargingFunctionElementServerTable
        {
            get => _chargingFunctionElementServerTable;
            set
            {
                ChargingFunctionElementServerTableSpecified = true;
                _chargingFunctionElementServerTable = value;
            }
        }

        [XmlIgnore]
        protected bool ChargingFunctionElementServerTableSpecified { get; set; }

    }
}
