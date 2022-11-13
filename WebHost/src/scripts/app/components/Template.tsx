import React, { useState } from "react";
import { Navigation } from "@components/Navigation";
import { Navigate, Route, Routes, useNavigate } from "react-router-dom";
import { Footer } from "./Footer";
import { Drawer } from "./Drawer";
import { WeeklyPlan } from "./WeeklyPlan";
export const Template: React.FC = () => {
  const navigate = useNavigate();

  return (
    <>
      <div className="drawer">
        <input id="my-drawer" type="checkbox" className="drawer-toggle" />
        <div className="drawer-content">
          <Navigation />
          <Routes>
            <Route path="/" element={<p>HOME</p>} />
            <Route path="/WeeklyPlan" element={<WeeklyPlan />} />
            <Route path="/MonthlyPlan" element={<p>Today's Plan</p>} />
            <Route path="/CreatePlan" element={<p>Create a plan</p>} />
            <Route path="*" element={<Navigate to={"/"}></Navigate>} />
          </Routes>
          <Footer />
        </div>
        <div className="drawer-side">
          <label htmlFor="my-drawer" className="drawer-overlay"></label>
          <ul className="menu p-4 w-80 bg-base-100 text-base-content">
            <label onClick={() => navigate("/WeeklyPlan")}>Weekly Plan</label>
            <label onClick={() => navigate("/MonthlyPlan")}>Today's Plan</label>
            <label onClick={() => navigate("/CreatePlan")}>Create a plan</label>

          </ul>
        </div>
      </div>
    </>
  );
};
