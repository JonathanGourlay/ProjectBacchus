import * as React from "react";
import { Template } from "@components/Template";
import "../../../styles/index.scss"
import { BrowserRouter } from "react-router-dom";

export const App: React.FC = () => {
  return <BrowserRouter><Template /></BrowserRouter>;
};
