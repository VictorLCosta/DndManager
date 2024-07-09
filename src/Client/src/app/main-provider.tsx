import { QueryClientProvider } from "@tanstack/react-query";

import { queryClient } from "@/lib/react-query";
import GlobalStyle from "@/styles/global-style";

type AppProviderProps = {
  children: React.ReactNode;
};

export default function AppProvider({ children }: AppProviderProps) {
  return (
    <QueryClientProvider client={queryClient}>
      <GlobalStyle />
      {children}
    </QueryClientProvider>
  );
}
