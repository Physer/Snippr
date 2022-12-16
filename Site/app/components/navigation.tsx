export default function Navigation() {
  return (
    <div className="relative h-16 bg-slate-200 dark:bg-slate-600 min-h-fit">
      <div className="absolute inset-y-0 left-0">
        {/* Some kind of issue with Next's components for now... */}
        <a href="/">
          <img src="/logo-no-background.png" alt="Snippr" className="h-full" />
        </a>
      </div>
      <div className="absolute inset-y-0 right-0 flex flex-row ">
        <a href="#" className="h-10">
          TODO: Settings
          {/* <img src="/settings.png" alt="Settings" className="object-cover" /> */}
        </a>
        <a href="#" className="h-10">
          TODO: Profile
          {/* <img src="/profile.png" alt="Profile" className="h-10" /> */}
        </a>
      </div>
    </div>
  );
}
