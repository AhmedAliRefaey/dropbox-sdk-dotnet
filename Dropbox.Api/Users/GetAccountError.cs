// <auto-generated>
// Auto-generated by BabelAPI, do not modify.
// </auto-generated>

namespace Dropbox.Api.Users
{
    using sys = System;
    using col = System.Collections.Generic;
    using re = System.Text.RegularExpressions;

    using enc = Dropbox.Api.Babel;

    /// <summary>
    /// <para>The get account error object</para>
    /// </summary>
    public class GetAccountError : enc.IEncodable<GetAccountError>
    {
        /// <summary>
        /// <para>Initializes a new instance of the GetAccountError class.</para>
        /// </summary>
        public GetAccountError()
        {
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is NoAccount</para>
        /// </summary>
        public bool IsNoAccount
        {
            get
            {
                return this is NoAccount;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a NoAccount, or <c>null</c>.</para>
        /// </summary>
        public NoAccount AsNoAccount
        {
            get
            {
                return this as NoAccount;
            }
        }

        /// <summary>
        /// <para>Gets a value indicating whether this instance is Unknown</para>
        /// </summary>
        public bool IsUnknown
        {
            get
            {
                return this is Unknown;
            }
        }

        /// <summary>
        /// <para>Gets this instance as a Unknown, or <c>null</c>.</para>
        /// </summary>
        public Unknown AsUnknown
        {
            get
            {
                return this as Unknown;
            }
        }

        #region IEncodable<GetAccountError> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<GetAccountError>.Encode(enc.IEncoder encoder)
        {
            if (this.IsNoAccount)
            {
                ((enc.IEncodable<NoAccount>)this).Encode(encoder);
            }
            else
            {
                ((enc.IEncodable<Unknown>)this).Encode(encoder);
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        GetAccountError enc.IEncodable<GetAccountError>.Decode(enc.IDecoder decoder)
        {
            switch (decoder.GetUnionName())
            {
            case "no_account":
                return NoAccount.Instance;
            default:
                return Unknown.Instance;
            }
        }

        #endregion

        /// <summary>
        /// <para>The specified <see cref="GetAccountArg.AccountId" /> does not exist.</para>
        /// </summary>
        public sealed class NoAccount : GetAccountError, enc.IEncodable<NoAccount>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="NoAccount" /> class.</para>
            /// </summary>
            private NoAccount()
            {
            }

            /// <summary>
            /// <para>A singleton instance of NoAccount</para>
            /// </summary>
            public static readonly NoAccount Instance = new NoAccount();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<NoAccount>.Encode(enc.IEncoder encoder)
            {
                encoder.AddUnion("no_account");
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            NoAccount enc.IEncodable<NoAccount>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }

        /// <summary>
        /// <para>The unknown object</para>
        /// </summary>
        public sealed class Unknown : GetAccountError, enc.IEncodable<Unknown>
        {
            /// <summary>
            /// <para>Initializes a new instance of the <see cref="Unknown" /> class.</para>
            /// </summary>
            private Unknown()
            {
            }

            /// <summary>
            /// <para>A singleton instance of Unknown</para>
            /// </summary>
            public static readonly Unknown Instance = new Unknown();

            /// <summary>
            /// <para>Encodes the object using the supplied encoder.</para>
            /// </summary>
            /// <param name="encoder">The encoder being used to serialize the object.</param>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            void enc.IEncodable<Unknown>.Encode(enc.IEncoder encoder)
            {
                encoder.AddUnion("unknown");
            }

            /// <summary>
            /// <para>Decodes on object using the supplied decoder.</para>
            /// </summary>
            /// <param name="decoder">The decoder used to deserialize the object.</param>
            /// <returns>The deserialized object. Note: this is not necessarily the current
            /// instance.</returns>
            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
            Unknown enc.IEncodable<Unknown>.Decode(enc.IDecoder decoder)
            {
                throw new sys.InvalidOperationException("Decoding happens through the base class");
            }
        }
    }
}
