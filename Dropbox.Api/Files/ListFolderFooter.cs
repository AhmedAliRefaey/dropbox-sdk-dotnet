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
    /// <para>The list folder footer object</para>
    /// </summary>
    /// <seealso cref="ListFolderContinueResult" />
    /// <seealso cref="ListFolderResult" />
    public sealed class ListFolderFooter : enc.IEncodable<ListFolderFooter>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListFolderFooter" />
        /// class.</para>
        /// </summary>
        /// <param name="cursor">Pass the cursor into <see
        /// cref="Dropbox.Api.Files.Routes.FilesRoutes.ListFolderContinueAsync" /> to see
        /// what's changed in the folder since your previous query.</param>
        /// <param name="hasMore">If true, then there are more entries available.</param>
        public ListFolderFooter(string cursor,
                                bool hasMore)
        {
            if (cursor == null)
            {
                throw new sys.ArgumentNullException("cursor");
            }

            this.Cursor = cursor;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="ListFolderFooter" />
        /// class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public ListFolderFooter()
        {
        }

        /// <summary>
        /// <para>Pass the cursor into <see
        /// cref="Dropbox.Api.Files.Routes.FilesRoutes.ListFolderContinueAsync" /> to see
        /// what's changed in the folder since your previous query.</para>
        /// </summary>
        public string Cursor { get; private set; }

        /// <summary>
        /// <para>If true, then there are more entries available.</para>
        /// </summary>
        public bool HasMore { get; private set; }

        #region IEncodable<ListFolderFooter> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<ListFolderFooter>.Encode(enc.IEncoder encoder)
        {
            using (var obj = encoder.AddObject())
            {
                obj.AddField<string>("cursor", this.Cursor);
                obj.AddField<bool>("has_more", this.HasMore);
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        ListFolderFooter enc.IEncodable<ListFolderFooter>.Decode(enc.IDecoder decoder)
        {
            using (var obj = decoder.GetObject())
            {
                this.Cursor = obj.GetField<string>("cursor");
                this.HasMore = obj.GetField<bool>("has_more");

                return this;
            }
        }

        #endregion
    }
}
