export default function Toolbar() {
  return (
    <nav className="h-screen w-20 bg-slate-600 min-h-fit flex flex-col items-center pt-6">
      <div>
        <a href="/">
          <img src="/explorer.png" alt="Explorer" className="h-10 w-10" />
        </a>
      </div>
    </nav>
  );
}
