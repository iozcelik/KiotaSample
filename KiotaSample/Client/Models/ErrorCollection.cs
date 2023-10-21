// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Error messages from an operation.
    /// </summary>
    public class ErrorCollection : ApiException, IParsable {
        /// <summary>The list of error messages produced by this operation. For example, &quot;input parameter &apos;key&apos; must be provided&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ErrorMessages { get; set; }
#nullable restore
#else
        public List<string> ErrorMessages { get; set; }
#endif
        /// <summary>The list of errors by parameter returned by the operation. For example,&quot;projectKey&quot;: &quot;Project keys must start with an uppercase letter, followed by one or more uppercase alphanumeric characters.&quot;</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ErrorCollection_errors? Errors { get; set; }
#nullable restore
#else
        public ErrorCollection_errors Errors { get; set; }
#endif
        /// <summary>The primary error message.</summary>
        public override string Message { get => base.Message; }
        /// <summary>The status property</summary>
        public int? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static ErrorCollection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ErrorCollection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"errorMessages", n => { ErrorMessages = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"errors", n => { Errors = n.GetObjectValue<ErrorCollection_errors>(ErrorCollection_errors.CreateFromDiscriminatorValue); } },
                {"status", n => { Status = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfPrimitiveValues<string>("errorMessages", ErrorMessages);
            writer.WriteObjectValue<ErrorCollection_errors>("errors", Errors);
            writer.WriteIntValue("status", Status);
        }
    }
}