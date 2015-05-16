// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Files
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The upload commit error object</para>
    /// </summary>
    public sealed class UploadCommitError : enc.IEncodable<UploadCommitError>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UploadCommitError" />
        /// class.</para>
        /// </summary>
        /// <param name="reason">The reason</param>
        /// <param name="uploadSessionId">The upload session id</param>
        public UploadCommitError(CommitError reason,
                                 string uploadSessionId)
        {
            if (reason == null)
            {
                throw new sys.ArgumentNullException("reason");
            }

            if (uploadSessionId == null)
            {
                throw new sys.ArgumentNullException("uploadSessionId");
            }

            this.Reason = reason;
            this.UploadSessionId = uploadSessionId;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="UploadCommitError" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public UploadCommitError()
        {
        }

        /// <summary>
        /// <para>Gets the reason of the upload commit error</para>
        /// </summary>
        public CommitError Reason { get; private set; }

        /// <summary>
        /// <para>Gets the upload session id of the upload commit error</para>
        /// </summary>
        public string UploadSessionId { get; private set; }

        #region IEncodable<UploadCommitError> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<UploadCommitError>.Encode(enc.IEncoder encoder)
        {
            using (var obj = encoder.AddObject())
            {
                obj.AddFieldObject<CommitError>("reason", this.Reason);
                obj.AddField<string>("upload_session_id", this.UploadSessionId);
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        UploadCommitError enc.IEncodable<UploadCommitError>.Decode(enc.IDecoder decoder)
        {
            using (var obj = decoder.GetObject())
            {
                this.Reason = obj.GetFieldObject<CommitError>("reason");
                this.UploadSessionId = obj.GetField<string>("upload_session_id");

                return this;
            }
        }

        #endregion
    }
}
