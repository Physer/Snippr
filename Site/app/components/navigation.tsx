export default function Navigation() {
  return (
    <nav className="h-16 bg-slate-200 dark:bg-slate-600 min-h-fit flex flex-row items-center justify-between">
      <div className="h-full">
        {/* Some kind of issue with Next's components for now... */}
        <a href="/">
          <img src="/logo-no-background.png" alt="Snippr" className="h-full px-4"/>
        </a>
      </div>
      <div className="h-8 order-last">
        <a href="#">
          <img src="/profile.png" alt="Profile" className="h-8 pr-4"/>
        </a>
      </div>
    </nav>
  );
}
