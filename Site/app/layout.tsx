import Navigation from "./components/navigation";
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
      <body className="h-screen bg-slate-200 dark:bg-zinc-800 dark:text-slate-200">
        <Navigation />
        {children}
      </body>
    </html>
  );
}
