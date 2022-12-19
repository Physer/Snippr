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
        <Toolbar />
        {children}
      </body>
    </html>
  );
}
