import * as React from "react";
import { Template } from "@components/Template";
import "../../../styles/index.scss"
import { BrowserRouter } from "react-router-dom";
import AppStateContainer from "hooks/appStateContainer";
import { QueryClient, QueryClientProvider } from "@tanstack/react-query";

export const App: React.FC = () => {

  const queryClient = React.useMemo(() => { return new QueryClient() }, [])

  return <BrowserRouter>
    <QueryClientProvider client={queryClient}>
      <AppStateContainer.Provider>
        <Template />
      </AppStateContainer.Provider>
    </QueryClientProvider>
  </BrowserRouter>;
};
