import { createBrowserRouter } from "react-router-dom";

import type { QueryClient } from "@tanstack/react-query";

export const createRouter = (queryClient: QueryClient) =>
  createBrowserRouter([
    {
      path: "/",
      lazy: async () => {
        const MainMenu = await import("./main-menu");
        return { Component: MainMenu.default };
      },
    },
  ]);
