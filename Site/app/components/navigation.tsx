export default function Navigation() {
  return (
    <nav className="h-16 bg-slate-200 dark:bg-slate-600 min-h-fit flex items-center">
      <div className="h-full">
        {/* Some kind of issue with Next's components for now... */}
        <a href="/">
          <img src="/logo-no-background.png" alt="Snippr" className="h-full"/>
        </a>
      </div>
      <div className="h-8=">
        <a href="#">
          <img src="/profile.png" alt="Profile" className="h-8"/>
        </a>
      </div>
    </nav>
  );
}
