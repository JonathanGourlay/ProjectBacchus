
import React, { useState } from "react";
import { useEffect } from 'react'
import { themeChange } from 'theme-change'
import { BrowserRouter, useNavigate } from "react-router-dom";



export const Navigation: React.FC = () => {
    const navigate = useNavigate();
    useEffect(() => {
        themeChange(false)
        // 👆 false parameter is required for react project
    }, [])
    return (


        <div className="navbar bg-base-100">
            <div className="flex-none">
                <label htmlFor="my-drawer" className="btn btn-neutral drawer-button"><svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" className="inline-block w-5 h-5 stroke-current"><path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2" d="M4 6h16M4 12h16M4 18h16"></path></svg>
                </label>
            </div>
            <div className="flex-1">
                <a className="btn btn-ghost normal-case text-xl">Meal Planner</a>
            </div>
            <div className="flex-none">
                <div className="card-actions justify-end">
                    <div className="dropdown dropdown-end">
                        <ul tabIndex={0} className="dropdown-content menu p-2 shadow rounded-box w-52">
                            <p>Theme</p>
                            <li>
                                <select data-choose-theme className="select select-neutral w-full max-w-xs">
                                    <>
                                        {["light", "dark", "cupcake", "bumblebee", "emerald", "corporate", "synthwave", "retro", "cyberpunk", "valentine", "halloween", "garden", "forest", "aqua",
                                            "lofi", "pastel", "fantasy", "wireframe", "black", "luxury", "dracula", "cmyk", "autumn", "business", "acid", "lemonade", "night", "coffee", "winter"].map((theme, i) =>
                                                <option key={`${i}_${i}`} value={theme} className="bg-neutral">{theme}</option>
                                            )}
                                    </>
                                </select>
                            </li>
                        </ul>
                        <label tabIndex={0} className="btn m-1">
                            <svg xmlns="http://www.w3.org/2000/svg" fill="none" viewBox="0 0 24 24" className="inline-block w-5 h-5 stroke-current"><path strokeLinecap="round" strokeLinejoin="round" strokeWidth="2" d="M5 12h.01M12 12h.01M19 12h.01M6 12a1 1 0 11-2 0 1 1 0 012 0zm7 0a1 1 0 11-2 0 1 1 0 012 0zm7 0a1 1 0 11-2 0 1 1 0 012 0z"></path></svg>
                        </label>

                    </div>
                </div>
            </div>
        </div>
    );
};