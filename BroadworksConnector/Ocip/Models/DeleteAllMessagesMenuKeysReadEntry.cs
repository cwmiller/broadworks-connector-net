using System;
using System.Xml.Serialization;
using System.ComponentModel.DataAnnotations;
using BroadWorksConnector.Ocip.Validation;
using System.Collections.Generic;

namespace BroadWorksConnector.Ocip.Models
{
    /// <summary>
    /// The voice portal delete all messages menu keys.
    /// </summary>
    [Serializable]
    [XmlRoot(Namespace = "")]

    [Groups(@"[{""__type"":""Sequence:#BroadWorksConnector.Ocip.Validation"",""id"":""3347d430e0d5c93a9ff8dcf0e3b60d6c:2583""}]")]
    public class DeleteAllMessagesMenuKeysReadEntry
    {

        private string _confirmDeletion;

        [XmlElement(ElementName = "confirmDeletion", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2583")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string ConfirmDeletion
        {
            get => _confirmDeletion;
            set
            {
                ConfirmDeletionSpecified = true;
                _confirmDeletion = value;
            }
        }

        [XmlIgnore]
        public bool ConfirmDeletionSpecified { get; set; }

        private string _cancelDeletion;

        [XmlElement(ElementName = "cancelDeletion", IsNullable = false, Namespace = "")]
        [Group(@"3347d430e0d5c93a9ff8dcf0e3b60d6c:2583")]
        [Length(1)]
        [RegularExpression(@"[0-9]|\*|#")]
        public string CancelDeletion
        {
            get => _cancelDeletion;
            set
            {
                CancelDeletionSpecified = true;
                _cancelDeletion = value;
            }
        }

        [XmlIgnore]
        public bool CancelDeletionSpecified { get; set; }

    }
}
