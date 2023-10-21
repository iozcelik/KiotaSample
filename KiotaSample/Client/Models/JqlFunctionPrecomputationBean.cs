// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    /// <summary>
    /// Jql function precomputation.
    /// </summary>
    public class JqlFunctionPrecomputationBean : IParsable {
        /// <summary>The list of arguments function was invoked with.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? Arguments { get; private set; }
#nullable restore
#else
        public List<string> Arguments { get; private set; }
#endif
        /// <summary>The timestamp of the precomputation creation.</summary>
        public DateTimeOffset? Created { get; private set; }
        /// <summary>The error message to be displayed to the user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Error { get; private set; }
#nullable restore
#else
        public string Error { get; private set; }
#endif
        /// <summary>The field the function was executed against.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Field { get; private set; }
#nullable restore
#else
        public string Field { get; private set; }
#endif
        /// <summary>The function key.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FunctionKey { get; private set; }
#nullable restore
#else
        public string FunctionKey { get; private set; }
#endif
        /// <summary>The name of the function.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? FunctionName { get; private set; }
#nullable restore
#else
        public string FunctionName { get; private set; }
#endif
        /// <summary>The id of the precomputation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Id { get; private set; }
#nullable restore
#else
        public string Id { get; private set; }
#endif
        /// <summary>The operator in context of which function was executed.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Operator { get; private set; }
#nullable restore
#else
        public string Operator { get; private set; }
#endif
        /// <summary>The timestamp of the precomputation last update.</summary>
        public DateTimeOffset? Updated { get; private set; }
        /// <summary>The timestamp of the precomputation last usage.</summary>
        public DateTimeOffset? Used { get; private set; }
        /// <summary>The JQL fragment stored as the precomputation.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Value { get; private set; }
#nullable restore
#else
        public string Value { get; private set; }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static JqlFunctionPrecomputationBean CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new JqlFunctionPrecomputationBean();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"arguments", n => { Arguments = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"created", n => { Created = n.GetDateTimeOffsetValue(); } },
                {"error", n => { Error = n.GetStringValue(); } },
                {"field", n => { Field = n.GetStringValue(); } },
                {"functionKey", n => { FunctionKey = n.GetStringValue(); } },
                {"functionName", n => { FunctionName = n.GetStringValue(); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"operator", n => { Operator = n.GetStringValue(); } },
                {"updated", n => { Updated = n.GetDateTimeOffsetValue(); } },
                {"used", n => { Used = n.GetDateTimeOffsetValue(); } },
                {"value", n => { Value = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
        }
    }
}