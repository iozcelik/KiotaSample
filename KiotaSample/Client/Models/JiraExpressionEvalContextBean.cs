// <auto-generated/>
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace AtlassianClient.Models {
    public class JiraExpressionEvalContextBean : IParsable {
        /// <summary>The ID of the board that is available under the `board` variable when evaluating the expression.</summary>
        public long? Board { get; set; }
        /// <summary>Custom context variables and their types. These variable types are available for use in a custom context: *  `user`: A [user](https://developer.atlassian.com/cloud/jira/platform/jira-expressions-type-reference#user) specified as an Atlassian account ID. *  `issue`: An [issue](https://developer.atlassian.com/cloud/jira/platform/jira-expressions-type-reference#issue) specified by ID or key. All the fields of the issue object are available in the Jira expression. *  `json`: A JSON object containing custom content. *  `list`: A JSON list of `user`, `issue`, or `json` variable types.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<CustomContextVariable>? Custom { get; set; }
#nullable restore
#else
        public List<CustomContextVariable> Custom { get; set; }
#endif
        /// <summary>The ID of the customer request that is available under the `customerRequest` variable when evaluating the expression. This is the same as the ID of the underlying Jira issue, but the customer request context variable will have a different type.</summary>
        public long? CustomerRequest { get; set; }
        /// <summary>The issue that is available under the `issue` variable when evaluating the expression.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdOrKeyBean? Issue { get; set; }
#nullable restore
#else
        public IdOrKeyBean Issue { get; set; }
#endif
        /// <summary>The collection of issues that is available under the `issues` variable when evaluating the expression.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public JexpIssues? Issues { get; set; }
#nullable restore
#else
        public JexpIssues Issues { get; set; }
#endif
        /// <summary>The project that is available under the `project` variable when evaluating the expression.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdOrKeyBean? Project { get; set; }
#nullable restore
#else
        public IdOrKeyBean Project { get; set; }
#endif
        /// <summary>The ID of the service desk that is available under the `serviceDesk` variable when evaluating the expression.</summary>
        public long? ServiceDesk { get; set; }
        /// <summary>The ID of the sprint that is available under the `sprint` variable when evaluating the expression.</summary>
        public long? Sprint { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static JiraExpressionEvalContextBean CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new JiraExpressionEvalContextBean();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"board", n => { Board = n.GetLongValue(); } },
                {"custom", n => { Custom = n.GetCollectionOfObjectValues<CustomContextVariable>(CustomContextVariable.CreateFromDiscriminatorValue)?.ToList(); } },
                {"customerRequest", n => { CustomerRequest = n.GetLongValue(); } },
                {"issue", n => { Issue = n.GetObjectValue<IdOrKeyBean>(IdOrKeyBean.CreateFromDiscriminatorValue); } },
                {"issues", n => { Issues = n.GetObjectValue<JexpIssues>(JexpIssues.CreateFromDiscriminatorValue); } },
                {"project", n => { Project = n.GetObjectValue<IdOrKeyBean>(IdOrKeyBean.CreateFromDiscriminatorValue); } },
                {"serviceDesk", n => { ServiceDesk = n.GetLongValue(); } },
                {"sprint", n => { Sprint = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("board", Board);
            writer.WriteCollectionOfObjectValues<CustomContextVariable>("custom", Custom);
            writer.WriteLongValue("customerRequest", CustomerRequest);
            writer.WriteObjectValue<IdOrKeyBean>("issue", Issue);
            writer.WriteObjectValue<JexpIssues>("issues", Issues);
            writer.WriteObjectValue<IdOrKeyBean>("project", Project);
            writer.WriteLongValue("serviceDesk", ServiceDesk);
            writer.WriteLongValue("sprint", Sprint);
        }
    }
}