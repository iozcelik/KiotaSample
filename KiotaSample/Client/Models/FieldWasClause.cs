// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// A clause that asserts a previous value of a field. For example, `status WAS &quot;Resolved&quot; BY currentUser() BEFORE &quot;2019/02/02&quot;`. See [WAS](https://confluence.atlassian.com/x/dgiiLQ#Advancedsearching-operatorsreference-WASWAS) for more information about the WAS operator.
    /// </summary>
    public class FieldWasClause : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>A field used in a JQL query. See [Advanced searching - fields reference](https://confluence.atlassian.com/x/dAiiLQ) for more information about fields in JQL queries.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public JqlQueryField? Field { get; set; }
#nullable restore
#else
        public JqlQueryField Field { get; set; }
#endif
        /// <summary>Details of an operand in a JQL clause.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public JqlQueryClauseOperand? Operand { get; set; }
#nullable restore
#else
        public JqlQueryClauseOperand Operand { get; set; }
#endif
        /// <summary>The operator between the field and operand.</summary>
        public FieldWasClause_operator? Operator { get; set; }
        /// <summary>The list of time predicates.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<JqlQueryClauseTimePredicate>? Predicates { get; set; }
#nullable restore
#else
        public List<JqlQueryClauseTimePredicate> Predicates { get; set; }
#endif
        /// <summary>
        /// Instantiates a new FieldWasClause and sets the default values.
        /// </summary>
        public FieldWasClause() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static FieldWasClause CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FieldWasClause();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"field", n => { Field = n.GetObjectValue<JqlQueryField>(JqlQueryField.CreateFromDiscriminatorValue); } },
                {"operand", n => { Operand = n.GetObjectValue<JqlQueryClauseOperand>(JqlQueryClauseOperand.CreateFromDiscriminatorValue); } },
                {"operator", n => { Operator = n.GetEnumValue<FieldWasClause_operator>(); } },
                {"predicates", n => { Predicates = n.GetCollectionOfObjectValues<JqlQueryClauseTimePredicate>(JqlQueryClauseTimePredicate.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<JqlQueryField>("field", Field);
            writer.WriteObjectValue<JqlQueryClauseOperand>("operand", Operand);
            writer.WriteEnumValue<FieldWasClause_operator>("operator", Operator);
            writer.WriteCollectionOfObjectValues<JqlQueryClauseTimePredicate>("predicates", Predicates);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}