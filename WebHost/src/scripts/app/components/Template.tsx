import React, { useState } from "react";
import { Navigation } from "@components/Navigation";
import { Link, Navigate, Route, Routes, useNavigate } from "react-router-dom";
import { Footer } from "./Footer";
import { WeeklyPlan } from "./WeeklyPlan";
import { TodaysPlan } from "./TodaysPlan";
import { SearchRecipies } from "./SearchRecipies";
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
            <Route path="/TodaysPlan" element={<TodaysPlan />} />
            <Route path="/CreatePlan" element={<p>Create a plan</p>} />
            <Route path="/SearchRecipies" element={<SearchRecipies />} />
            <Route path="/ShoppingList" element={<p>Shopping List</p>} />
            <Route path="*" element={<Navigate to={"/"}></Navigate>} />
          </Routes>
          <Footer />
        </div>
        <div className="drawer-side">
          <label htmlFor="my-drawer" className="drawer-overlay"></label>
          <ul className="menu p-4 w-80 bg-base-100 text-base-content">
            <Link to={"/WeeklyPlan"}>Weekly Plan</Link>
            <Link to={"/TodaysPlan"}>Today's Plan</Link>
            <Link to={"/CreatePlan"}>Create a Plan</Link>
            <Link to={"/SearchRecipies"}>Search Recipies</Link>
            <Link to={"/ShoppingList"}>Shopping List</Link>
          </ul>
        </div>
      </div>
    </>
  );
};
