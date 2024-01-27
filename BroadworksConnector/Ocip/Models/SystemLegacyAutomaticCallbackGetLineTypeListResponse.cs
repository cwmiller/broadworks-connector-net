using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// Response to SystemLegacyAutomaticCallbackGetLineTypeListRequest. Returns a 3 column
    /// table with column headings: "Line Type", "Match" and "No Match". The possible values
    /// for the "Match" and "No Match" columns are "Accept" and "Deny".
    /// <see cref="SystemLegacyAutomaticCallbackGetLineTypeListRequest"/>
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""dd4a5e667a0f0e4bd6363152331d07ab:62""}]")]
    public class SystemLegacyAutomaticCallbackGetLineTypeListResponse : BroadWorksConnector.Ocip.Models.C.OCIDataResponse
    {

        protected BroadWorksConnector.Ocip.Models.C.OCITable _lineTypeTable;

        [XmlElement(ElementName = "lineTypeTable", IsNullable = false, Namespace = "")]
        [Group(@"dd4a5e667a0f0e4bd6363152331d07ab:62")]
        public BroadWorksConnector.Ocip.Models.C.OCITable LineTypeTable
        {
            get => _lineTypeTable;
            set
            {
                LineTypeTableSpecified = true;
                _lineTypeTable = value;
            }
        }

        [XmlIgnore]
        protected bool LineTypeTableSpecified { get; set; }

    }
}
