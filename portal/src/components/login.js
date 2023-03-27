import { useSession, signIn, signOut } from "next-auth/react"
export default function Login() {
  const { data: session } = useSession()
  if (session) {
    return (
      <>
        Signed in as {session.user.email} <br />
        access token : {session.accessToken}<br /><br />
        <button onClick={() => signOut()}>Sign out</button>
      </>
    )
  }
  return (
    <>
      Not signed in <br />
      <button onClick={() =>signIn("identity-server4")}>Sign in</button>
    </>
  )
}