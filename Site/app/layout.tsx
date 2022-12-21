import Explorer from "./components/explorer";
import Navigation from "./components/navigation";
import Toolbar from "./components/toolbar";
import "./globals.css";

export default function RootLayout({
  children,
}: {
  children: React.ReactNode;
}) {
  return (
    <html lang="en">
      {}
      <head />
      <body className="h-screen bg-zinc-800 dark:text-slate-200">
        <Navigation />
        <div className="flex flex-row">
          <Toolbar />
          <Explorer />
        </div>
        {children}
      </body>
    </html>
  );
}
