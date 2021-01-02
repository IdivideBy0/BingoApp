using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BingoApp.Models;
using BingoApp.Helpers;

namespace BingoApp.Controllers
{
    public class BoardController : Controller
    {
        // GET: Board
        public ActionResult Index()
        {
            //Board board = new Board();

            Board.InitBoard();

            BdHelper helper = new BdHelper { Brow = Board.Brow, Irow = Board.Irow, Nrow = Board.Nrow, Grow = Board.Grow, Orow = Board.Orow };
            helper.totalBalls = Ball.totalBalls;

            return View(helper);
        }

        // GET: Board/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Board/Create
        public ActionResult Create()
        {
            //Ball ball = new Ball();

            //ball.CreateBall();
            Ball.CreateBall();

            //BdHelper

            if(Ball.letter == 'B')
            {
                int pos = Board.Brow.IndexOf(0);
                if (pos != -1)
                {
                    Board.Brow.RemoveAt(pos);
                    Board.Brow.Add(Ball.number);
                    
                }
                else
                {
                    Create();
                }
            }

            if (Ball.letter == 'I')
            {
                int pos = Board.Irow.IndexOf(0);
                if (pos != -1)
                {
                    Board.Irow.RemoveAt(pos);
                    Board.Irow.Add(Ball.number);
                    
                }
                else
                {
                    Create();
                }
            }

            if (Ball.letter == 'N')
            {
                int pos = Board.Nrow.IndexOf(0);
                if (pos != -1)
                {
                    Board.Nrow.RemoveAt(pos);
                    Board.Nrow.Add(Ball.number);
                    
                }
                else
                {
                    Create();
                }
            }

            if (Ball.letter == 'G')
            {
                int pos = Board.Grow.IndexOf(0);
                if (pos != -1)
                {
                    Board.Grow.RemoveAt(pos);
                    Board.Grow.Add(Ball.number);
                    
                }
                else
                {
                    Create();
                }
            }

            if (Ball.letter == 'O')
            {
                int pos = Board.Orow.IndexOf(0);
                if (pos != -1)
                {
                    Board.Orow.RemoveAt(pos);
                    Board.Orow.Add(Ball.number);
                    
                }
                else
                {
                    Create();
                }
            }

            BdHelper helper = new BdHelper { Brow = Board.Brow, Irow = Board.Irow, Nrow = Board.Nrow, Grow = Board.Grow, Orow = Board.Orow };
            helper.totalBalls = Ball.totalBalls;
            helper.lastCalledBall =  new KeyValuePair<int, char>(Ball.number, Ball.letter); 


            return View(helper);
        }

        // POST: Board/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Board/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Board/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Board/Delete/5
        public ActionResult Delete()
        {
            //Ball ball = new Ball();

            //ball.Dispose();
            Ball.InitBalls();

            Board.InitBoard();

            BdHelper helper = new BdHelper { Brow = Board.Brow, Irow = Board.Irow, Nrow = Board.Nrow, Grow = Board.Grow, Orow = Board.Orow };
            helper.totalBalls = Ball.totalBalls;
            //helper.lastCalledBall = new KeyValuePair<int, char>(Ball.number, Ball.letter);

            return View(helper);

            
        }

        // POST: Board/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
