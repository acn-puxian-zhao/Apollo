import NextAuth from "next-auth";
import IdentityServer4 from "next-auth/providers/identity-server4";

export default NextAuth({
  // Configure one or more authentication providers
  providers: [
    IdentityServer4({
      id: "identity-server4",
      name: "IdentityServer4",
      issuer: process.env.IdentityServer4_Domain,
      clientId: process.env.IdentityServer4_CLIENT_ID,
      clientSecret: process.env.IdentityServer4_CLIENT_SECRET,
    }),
  ],
  callbacks: {
    async jwt({ token, account }) {
      console.log('jwt executed')
      // Persist the OAuth access_token to the token right after signin
      if (account) {
        token.accessToken = account.access_token
      }
      return token
    },
    async session({ session, token, user }) {
      console.log('session executed')
      // Send properties to the client, like an access_token from a provider.
      session.accessToken = token.accessToken
      return session
    }
  },
});
