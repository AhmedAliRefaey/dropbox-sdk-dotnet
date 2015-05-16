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
    /// <para>The get account arg object</para>
    /// </summary>
    public sealed class GetAccountArg : enc.IEncodable<GetAccountArg>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetAccountArg" /> class.</para>
        /// </summary>
        /// <param name="accountId">A user's account identifier.</param>
        public GetAccountArg(string accountId)
        {
            if (accountId == null)
            {
                throw new sys.ArgumentNullException("accountId");
            }
            else if (accountId.Length < 40 || accountId.Length > 40)
            {
                throw new sys.ArgumentOutOfRangeException("accountId");
            }

            this.AccountId = accountId;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="GetAccountArg" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public GetAccountArg()
        {
        }

        /// <summary>
        /// <para>A user's account identifier.</para>
        /// </summary>
        public string AccountId { get; private set; }

        #region IEncodable<GetAccountArg> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<GetAccountArg>.Encode(enc.IEncoder encoder)
        {
            using (var obj = encoder.AddObject())
            {
                obj.AddField<string>("account_id", this.AccountId);
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        GetAccountArg enc.IEncodable<GetAccountArg>.Decode(enc.IDecoder decoder)
        {
            using (var obj = decoder.GetObject())
            {
                this.AccountId = obj.GetField<string>("account_id");

                return this;
            }
        }

        #endregion
    }
}
