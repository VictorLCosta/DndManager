import GlobalStyle from "@/styles/global-style";

type AppProviderProps = {
  children: React.ReactNode;
};

export default function AppProvider({ children }: AppProviderProps) {
  return (
    <div>
      <GlobalStyle />
      {children}
    </div>
  );
}
