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
    /// <para>Detailed information about the current user's account.</para>
    /// </summary>
    /// <seealso cref="Account" />
    public sealed class FullAccount : enc.IEncodable<FullAccount>
    {
        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FullAccount" /> class.</para>
        /// </summary>
        /// <param name="accountId">The user's unique Dropbox ID.</param>
        /// <param name="name">Details of a user's name.</param>
        /// <param name="email">The user's e-mail address.</param>
        /// <param name="locale">The language that the user specified. Locale tags will be <a
        /// href="http://en.wikipedia.org/wiki/IETF_language_tag">IETF language
        /// tags</a>.</param>
        /// <param name="referralLink">The user's <a
        /// href="https://www.dropbox.com/referrals">referral link</a>.</param>
        /// <param name="isPaired">Whether the user has a personal and work account. If the
        /// current account is personal, then <paramref name="team" /> will always be
        /// <c>null</c>, but <paramref name="isPaired" /> will indicate if a work account is
        /// linked.</param>
        /// <param name="country">The user's two-letter country code, if available. Country
        /// codes are based on <a href="http://en.wikipedia.org/wiki/ISO_3166-1">ISO
        /// 3166-1</a>.</param>
        /// <param name="team">If this account is a member of a team, information about that
        /// team.</param>
        public FullAccount(string accountId,
                           Name name,
                           string email,
                           string locale,
                           string referralLink,
                           bool isPaired,
                           string country = null,
                           Team team = null)
        {
            if (accountId == null)
            {
                throw new sys.ArgumentNullException("accountId");
            }
            else if (accountId.Length < 40 || accountId.Length > 40)
            {
                throw new sys.ArgumentOutOfRangeException("accountId");
            }

            if (name == null)
            {
                throw new sys.ArgumentNullException("name");
            }

            if (email == null)
            {
                throw new sys.ArgumentNullException("email");
            }

            if (locale == null)
            {
                throw new sys.ArgumentNullException("locale");
            }
            else if (locale.Length < 2 || locale.Length > 2)
            {
                throw new sys.ArgumentOutOfRangeException("locale");
            }

            if (referralLink == null)
            {
                throw new sys.ArgumentNullException("referralLink");
            }

            if (country != null && (country.Length < 2 || country.Length > 2))
            {
                throw new sys.ArgumentOutOfRangeException("country");
            }

            this.AccountId = accountId;
            this.Name = name;
            this.Email = email;
            this.Locale = locale;
            this.ReferralLink = referralLink;
            this.IsPaired = isPaired;
            this.Country = country;
            this.Team = team;
        }

        /// <summary>
        /// <para>Initializes a new instance of the <see cref="FullAccount" /> class.</para>
        /// </summary>
        /// <remarks>This is to construct an instance of the object when
        /// deserializing.</remarks>
        public FullAccount()
        {
        }

        /// <summary>
        /// <para>The user's unique Dropbox ID.</para>
        /// </summary>
        public string AccountId { get; private set; }

        /// <summary>
        /// <para>Details of a user's name.</para>
        /// </summary>
        public Name Name { get; private set; }

        /// <summary>
        /// <para>The user's e-mail address.</para>
        /// </summary>
        public string Email { get; private set; }

        /// <summary>
        /// <para>The language that the user specified. Locale tags will be <a
        /// href="http://en.wikipedia.org/wiki/IETF_language_tag">IETF language
        /// tags</a>.</para>
        /// </summary>
        public string Locale { get; private set; }

        /// <summary>
        /// <para>The user's <a href="https://www.dropbox.com/referrals">referral
        /// link</a>.</para>
        /// </summary>
        public string ReferralLink { get; private set; }

        /// <summary>
        /// <para>Whether the user has a personal and work account. If the current account is
        /// personal, then <see cref="Team" /> will always be <c>null</c>, but <see
        /// cref="IsPaired" /> will indicate if a work account is linked.</para>
        /// </summary>
        public bool IsPaired { get; private set; }

        /// <summary>
        /// <para>The user's two-letter country code, if available. Country codes are based on
        /// <a href="http://en.wikipedia.org/wiki/ISO_3166-1">ISO 3166-1</a>.</para>
        /// </summary>
        public string Country { get; private set; }

        /// <summary>
        /// <para>If this account is a member of a team, information about that team.</para>
        /// </summary>
        public Team Team { get; private set; }

        #region IEncodable<FullAccount> methods

        /// <summary>
        /// <para>Encodes the object using the supplied encoder.</para>
        /// </summary>
        /// <param name="encoder">The encoder being used to serialize the object.</param>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        void enc.IEncodable<FullAccount>.Encode(enc.IEncoder encoder)
        {
            using (var obj = encoder.AddObject())
            {
                obj.AddField<string>("account_id", this.AccountId);
                obj.AddFieldObject<Name>("name", this.Name);
                obj.AddField<string>("email", this.Email);
                obj.AddField<string>("locale", this.Locale);
                obj.AddField<string>("referral_link", this.ReferralLink);
                obj.AddField<bool>("is_paired", this.IsPaired);
                if (this.Country != null)
                {
                    obj.AddField<string>("country", this.Country);
                }
                if (this.Team != null)
                {
                    obj.AddFieldObject<Team>("team", this.Team);
                }
            }
        }

        /// <summary>
        /// <para>Decodes on object using the supplied decoder.</para>
        /// </summary>
        /// <param name="decoder">The decoder used to deserialize the object.</param>
        /// <returns>The deserialized object. Note: this is not necessarily the current
        /// instance.</returns>
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        FullAccount enc.IEncodable<FullAccount>.Decode(enc.IDecoder decoder)
        {
            using (var obj = decoder.GetObject())
            {
                this.AccountId = obj.GetField<string>("account_id");
                this.Name = obj.GetFieldObject<Name>("name");
                this.Email = obj.GetField<string>("email");
                this.Locale = obj.GetField<string>("locale");
                this.ReferralLink = obj.GetField<string>("referral_link");
                this.IsPaired = obj.GetField<bool>("is_paired");
                if (obj.HasField("country"))
                {
                    this.Country = obj.GetField<string>("country");
                }
                if (obj.HasField("team"))
                {
                    this.Team = obj.GetFieldObject<Team>("team");
                }

                return this;
            }
        }

        #endregion
    }
}
