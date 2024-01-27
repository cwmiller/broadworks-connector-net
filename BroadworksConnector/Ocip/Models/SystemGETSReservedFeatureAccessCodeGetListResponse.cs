using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemGETSReservedFeatureAccessCodeGetListRequest.
    /// The table columns are: "Code" and "Description".
    /// <see cref="SystemGETSReservedFeatureAccessCodeGetListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""da582a1f8028404e70d260cf1f891033:11143""}]")]
    public class SystemGETSReservedFeatureAccessCodeGetListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _reservedCodeTable;

        [XmlElement(ElementName = "reservedCodeTable", IsNullable = false, Namespace = "")]
        [Group(@"da582a1f8028404e70d260cf1f891033:11143")]
        public BroadWorksConnector.Ocip.Models.C.OCITable ReservedCodeTable
        {
            get => _reservedCodeTable;
            set
            {
                ReservedCodeTableSpecified = true;
                _reservedCodeTable = value;
            }
        }

        [XmlIgnore]
        protected bool ReservedCodeTableSpecified { get; set; }

    }
}
